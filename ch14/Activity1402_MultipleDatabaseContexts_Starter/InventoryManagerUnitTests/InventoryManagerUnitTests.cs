using AutoMapper;
using InventoryBusinessLayer;
using InventoryDatabaseCore;
using InventoryDatabaseLayer;
using InventoryModels;
using InventoryModels.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagerUnitTests
{
    [TestClass]
    public class InventoryManagerUnitTests
    {
        private List<Item> _allItems;
        private List<CategoryColor> _allColors;
        private List<Category> _allCategories;
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

        private IItemsService _serviceLayer;
        //private Mock<IItemsService> _mockServiceLayer; 
        private static MapperConfiguration _mapperConfig;
        private static IMapper _mapper;
        private static IServiceProvider _serviceProvider;
        public TestContext TestContext { get; set; }
        private Mock<IInventoryDatabaseRepo> _mockInventoryDatabaseRepo;

        [ClassInitialize]
        public static void BeforeAllTests(TestContext testContext)
        {
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

        [TestInitialize]
        public void testBeforeTestRuns()
        {
            _mockInventoryDatabaseRepo = new Mock<IInventoryDatabaseRepo>();
            SetupDbRepoMock();
            _serviceLayer = new ItemsService(_mockInventoryDatabaseRepo.Object, _mapper);
            var items = new List<ItemDto>() {
                new ItemDto() { Id = 1, Name="Star Wars IV: A New Hope"
                                    , Description = "Luke's Friends", CategoryId = 2  },
                new ItemDto() { Id = 2, Name="Star Wars V: The Empire Strikes Back"
                                    , Description = "Luke's Dad", CategoryId = 2  },
                new ItemDto() { Id = 3, Name="Star Wars VI: The Return of the Jedi"
                                    , Description = "Luke's Sister", CategoryId = 2}
            };

            //_mockServiceLayer = new Mock<IItemsService>();
            //_mockServiceLayer.Setup(m => m.ListInventory()).Returns(items);
        }

        private void SetupDbRepoMock()
        {
            _allColors = new List<CategoryColor>() {
                new CategoryColor(){ Id = 1, ColorValue = COLOR_BLUE },
                new CategoryColor() { Id = 2, ColorValue = COLOR_RED },
                new CategoryColor() { Id = 3, ColorValue = COLOR_GREEN}
            };
            var color1 = _allColors.Single(x => x.Id == 1);
            var color2 = _allColors.Single(x => x.Id == 2);
            var color3 = _allColors.Single(x => x.Id == 3);

            _allCategories = new List<Category>() {
                new Category() {Id = 1, CategoryColorId = 1, CategoryColor = color1
                                , IsDeleted = false, IsActive = true, Name = CAT1_NAME },
                new Category() {Id = 2, CategoryColorId = 2, CategoryColor = color2
                                , IsDeleted = false, IsActive = true, Name = CAT2_NAME },
                new Category() {Id = 3, CategoryColorId = 3, CategoryColor = color3
                                , IsDeleted = false, IsActive = true, Name = CAT3_NAME }
            };
            var category1 = _allCategories.Single(x => x.Id == 1);
            var category2 = _allCategories.Single(x => x.Id == 2);
            var category3 = _allCategories.Single(x => x.Id == 3);

            _allItems = new List<Item>() {
                new Item() { Id = 1, CategoryId = 1, Category= category1, IsDeleted = false
                                , IsActive = true, Name = ITEM1_NAME, Description = ITEM1_DESC
                                , Notes = ITEM1_NOTES },
                new Item() { Id = 2, CategoryId = 2, Category= category2, IsDeleted = false
                                , IsActive = true, Name = ITEM2_NAME, Description = ITEM2_DESC
                                , Notes = ITEM2_NOTES },
                new Item() { Id = 3, CategoryId = 3, Category= category3, IsDeleted = false
                                , IsActive = true, Name = ITEM3_NAME, Description = ITEM3_DESC
                                , Notes = ITEM3_NOTES }
            };

            _mockInventoryDatabaseRepo.Setup(x => x.ListInventory())
                                .Returns(Task.FromResult(_allItems));
        }


        [TestMethod]
        public async Task TestGetItems()
        {
            //var result = _mockServiceLayer.Object.ListInventory();
            var result = await _serviceLayer.ListInventory();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
            result.ShouldNotBeNull();
            result.Count.ShouldBeGreaterThan(0);
            result.Count.ShouldBe(3);
            result.First().Name.ShouldBe(ITEM1_NAME);
            result.First().CategoryId.ShouldBe(1);
        }
    }
}
