using AutoMapper;
using InventoryDatabaseCore;
using InventoryDatabaseLayer;
using InventoryModels;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace InventoryManagerIntegrationTests
{
    public class InventoryManagerIntegrationTests
    {
        private const string COLOR_BLUE = "Blue";
        private const string COLOR_RED = "Red";
        private const string COLOR_GREEN = "Green";
        private const string CAT1_NAME = "CAT1 Books";
        private const string CAT2_NAME = "CAT2 Movies";
        private const string CAT3_NAME = "CAT3 Music";
        private const string ITEM1_NAME = "Item 1 Name";
        private const string ITEM2_NAME = "Item 2 Name";
        private const string ITEM3_NAME = "Item 3 Name";
        private const string ITEM1_DESC = "Item 1 DESC";
        private const string ITEM2_DESC = "Item 2 DESC";
        private const string ITEM3_DESC = "Item 3 DESC";
        private const string ITEM1_NOTES = "Item 1 Notes Good";
        private const string ITEM2_NOTES = "Item 2 Notes Fair";
        private const string ITEM3_NOTES = "Item 3 Notes Poor";

        DbContextOptions<InventoryDbContext> _options;
        private static MapperConfiguration _mapperConfig;
        private static IMapper _mapper;
        private static IServiceProvider _serviceProvider;
        private IInventoryDatabaseRepo _dbRepo;

        //DAPPER Testing
        private const string sqlLiteConnectionString = "DataSource=:memory:";
        private SqliteConnection _connection;
        private InventoryDbContext _context;

        public InventoryManagerIntegrationTests()
        {
            SetupOptions();
            BuildDefaults();
            SetupSqlite();
        }

        private void SetupSqlite() 
        {
            _connection = new SqliteConnection(sqlLiteConnectionString);
            _connection.Open();
            var options = new DbContextOptionsBuilder<InventoryDbContext>()
                    .UseSqlite(_connection)
                    .Options;
            _context = new InventoryDbContext(options);
            _context.Database.EnsureCreated();
            BuildSqliteData();
        }

        private void SetupOptions()
        {
            _options = new DbContextOptionsBuilder<InventoryDbContext>()
                            .UseInMemoryDatabase(databaseName: "InventoryManagerTest")
                            .Options;
            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(InventoryMapper));
            _serviceProvider = services.BuildServiceProvider();

            _mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<InventoryMapper>();
            });
            _mapperConfig.AssertConfigurationIsValid();
            _mapper = _mapperConfig.CreateMapper();
        }


        [Fact]
        public async Task TestListInventory()
        {
            using (var context = new InventoryDbContext(_options))
            {
                //act
                _dbRepo = new InventoryDatabaseRepo(context, _mapper);
                var items = await _dbRepo.ListInventory();

                //assert
                items.ShouldNotBeNull();
                items.Count.ShouldBe(3);
                var first = items.First();
                first.Name.ShouldBe(ITEM1_NAME);
                first.Description.ShouldBe(ITEM1_DESC);
                first.Notes.ShouldBe(ITEM1_NOTES);
                first.Category.Name.ShouldBe(CAT1_NAME);
            }
        }

        [Theory]
        [InlineData(CAT1_NAME, COLOR_BLUE)]
        [InlineData(CAT2_NAME, COLOR_RED)]
        [InlineData(CAT3_NAME, COLOR_GREEN)]
        public async Task TestCategoryColors(string name, string color)
        {
            //arrange
            using (var context = new InventoryDbContext(_options))
            {
                //act
                _dbRepo = new InventoryDatabaseRepo(context, _mapper);
                var catcolors = await _dbRepo.ListCategoriesAndColors();

                catcolors.ShouldNotBeNull();
                catcolors.Count.ShouldBe(3);

                var item = catcolors.FirstOrDefault(x => x.Category.Equals(name));
                item.ShouldNotBeNull();
                item.CategoryColor.Color.ShouldBe(color);
            }
        }

        [Fact]
        public async Task TestDapperListInventory()
        {
            var repo = new InventoryDatabaseDapperRepo(_context.Database.GetDbConnection(), _mapper);
            var result = await repo.ListInventory();

            result.ShouldNotBeNull();
            result.Count.ShouldBe(3);
            var one = result.Single(x => x.Name == ITEM1_NAME);
            one.ShouldNotBeNull();
            one.Name.ShouldBe(ITEM1_NAME);
            one.Description.ShouldBe(ITEM1_DESC);
            one.Notes.ShouldBe(ITEM1_NOTES);
            one.Category.Name.ShouldBe(CAT1_NAME);

            var two = result.Single(x => x.Name == ITEM2_NAME);
            two.ShouldNotBeNull();
            two.Name.ShouldBe(ITEM2_NAME);
            two.Description.ShouldBe(ITEM2_DESC);
            two.Notes.ShouldBe(ITEM2_NOTES);
            two.Category.Name.ShouldBe(CAT2_NAME);

            var three = result.Single(x => x.Name == ITEM3_NAME);
            three.ShouldNotBeNull();
            three.Name.ShouldBe(ITEM3_NAME);
            three.Description.ShouldBe(ITEM3_DESC);
            three.Notes.ShouldBe(ITEM3_NOTES);
            three.Category.Name.ShouldBe(CAT3_NAME);
        }

        [Theory]
        [InlineData(CAT1_NAME, COLOR_BLUE)]
        [InlineData(CAT2_NAME, COLOR_RED)]
        [InlineData(CAT3_NAME, COLOR_GREEN)]
        public async Task TestDapperCategoryColors(string name, string color)
        {
            var repo = new InventoryDatabaseDapperRepo(_context.Database.GetDbConnection(), _mapper);
            var catcolors = await repo.ListCategoriesAndColors();
            catcolors.ShouldNotBeNull();
            catcolors.Count.ShouldBe(3);

            var item = catcolors.SingleOrDefault(x => x.Category.Equals(name));
            item.ShouldNotBeNull();
            item.CategoryColor.Color.ShouldBe(color);
        }


        private void BuildDefaults()
        {
            using (var context = new InventoryDbContext(_options))
            {
                //skip creation if items already exist:
                var item1Detail = context.Items.SingleOrDefault(x => x.Name.Equals(ITEM1_NAME));
                var item2Detail = context.Items.SingleOrDefault(x => x.Name.Equals(ITEM2_NAME));
                var item3Detail = context.Items.SingleOrDefault(x => x.Name.Equals(ITEM3_NAME));
                if (item1Detail != null && item2Detail != null && item3Detail != null) return;

                var color1 = new CategoryColor() { ColorValue = COLOR_BLUE };
                var color2 = new CategoryColor() { ColorValue = COLOR_RED };
                var color3 = new CategoryColor() { ColorValue = COLOR_GREEN };

                var cat1 = new Category() {  CategoryColor = color1, IsActive = true, IsDeleted = false
                                                , Name = CAT1_NAME };
                var cat2 = new Category() {  CategoryColor = color2, IsActive = true, IsDeleted = false
                                                , Name = CAT2_NAME };
                var cat3 = new Category() {  CategoryColor = color3, IsActive = true, IsDeleted = false
                                                , Name = CAT3_NAME };
                context.Categories.Add(cat1);
                context.Categories.Add(cat2);
                context.Categories.Add(cat3);
                context.SaveChanges();

                var category1 = context.Categories.Single(x => x.Name.Equals(CAT1_NAME));
                var category2 = context.Categories.Single(x => x.Name.Equals(CAT2_NAME));
                var category3 = context.Categories.Single(x => x.Name.Equals(CAT3_NAME));

                var item1 = new Item() { Name = ITEM1_NAME, Description = ITEM1_DESC, Notes = ITEM1_NOTES
                                            , IsActive = true, IsDeleted = false, CategoryId = category1.Id };
                context.Items.Add(item1);
                var item2 = new Item() { Name = ITEM2_NAME, Description = ITEM2_DESC, Notes = ITEM2_NOTES
                                            , IsActive = true, IsDeleted = false, CategoryId = category2.Id };
                context.Items.Add(item2);
                var item3 = new Item() { Name = ITEM3_NAME, Description = ITEM3_DESC, Notes = ITEM3_NOTES
                                            , IsActive = true, IsDeleted = false, CategoryId = category3.Id };
                context.Items.Add(item3);
                context.SaveChanges();
            }

        }

        private void BuildSqliteData()
        {
            //skip creation if items already exist:
            var item1Detail = _context.Items.SingleOrDefault(x => x.Name.Equals(ITEM1_NAME));
            var item2Detail = _context.Items.SingleOrDefault(x => x.Name.Equals(ITEM2_NAME));
            var item3Detail = _context.Items.SingleOrDefault(x => x.Name.Equals(ITEM3_NAME));
            if (item1Detail != null && item2Detail != null && item3Detail != null) return;

            var color1 = new CategoryColor() { ColorValue = COLOR_BLUE };
            var color2 = new CategoryColor() { ColorValue = COLOR_RED };
            var color3 = new CategoryColor() { ColorValue = COLOR_GREEN };

            var cat1 = new Category()
            {
                CategoryColor = color1,
                IsActive = true,
                IsDeleted = false,
                Name = CAT1_NAME
            };
            var cat2 = new Category()
            {
                CategoryColor = color2,
                IsActive = true,
                IsDeleted = false,
                Name = CAT2_NAME
            };
            var cat3 = new Category()
            {
                CategoryColor = color3,
                IsActive = true,
                IsDeleted = false,
                Name = CAT3_NAME
            };
            _context.Categories.Add(cat1);
            _context.Categories.Add(cat2);
            _context.Categories.Add(cat3);
            _context.SaveChanges();

            //with sql lite, need to build out the id for the category.categorycolorid for mappings
            var catColor1 = _context.CategoryColors.Single(x => x.ColorValue.Equals(COLOR_BLUE));
            var catColor2 = _context.CategoryColors.Single(x => x.ColorValue.Equals(COLOR_RED));
            var catColor3 = _context.CategoryColors.Single(x => x.ColorValue.Equals(COLOR_GREEN));
            var category1 = _context.Categories.Single(x => x.Name.Equals(CAT1_NAME));
            var category2 = _context.Categories.Single(x => x.Name.Equals(CAT2_NAME));
            var category3 = _context.Categories.Single(x => x.Name.Equals(CAT3_NAME));

            category1.CategoryColorId = catColor1.Id;
            category2.CategoryColorId = catColor2.Id;
            category3.CategoryColorId = catColor3.Id;
            _context.SaveChanges();

            var item1 = new Item()
            {
                Name = ITEM1_NAME,
                Description = ITEM1_DESC,
                Notes = ITEM1_NOTES,
                IsActive = true,
                IsDeleted = false,
                CategoryId = category1.Id
            };
            _context.Items.Add(item1);
            var item2 = new Item()
            {
                Name = ITEM2_NAME,
                Description = ITEM2_DESC,
                Notes = ITEM2_NOTES,
                IsActive = true,
                IsDeleted = false,
                CategoryId = category2.Id
            };
            _context.Items.Add(item2);
            var item3 = new Item()
            {
                Name = ITEM3_NAME,
                Description = ITEM3_DESC,
                Notes = ITEM3_NOTES,
                IsActive = true,
                IsDeleted = false,
                CategoryId = category3.Id
            };
            _context.Items.Add(item3);
            _context.SaveChanges();
        }

    }

}
