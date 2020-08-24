using AutoMapper;
using Dapper;
using InventoryModels;
using InventoryModels.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace InventoryDatabaseLayer
{
    public class InventoryDatabaseDapperRepo : IInventoryDatabaseRepoReadOnly
    {
        private readonly IDbConnection _connection;
        private readonly IMapper _mapper;

        public InventoryDatabaseDapperRepo(IDbConnection connection, IMapper mapper)
        {
            _connection = connection;
            _mapper = mapper;

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public List<GetItemsForListingDto> GetItemsForListingFromProcedure(DateTime dateDateValue, DateTime maxDateValue)
        {
            throw new NotImplementedException();
        }

        public List<GetItemsForListingWithDateDto> GetItemsForListingLinq(DateTime minDateValue, DateTime maxDateValue)
        {
            throw new NotImplementedException();
        }

        public List<GetItemsTotalValueDto> GetItemsTotalValues(bool isActive)
        {
            throw new NotImplementedException();
        }

        public List<ItemsWithGenresDto> GetItemsWithGenres()
        {
            throw new NotImplementedException();
        }

        public List<CategoryDto> ListCategoriesAndColors()
        {
            var sql = "SELECT c.Id, c.Name, cc.Id as CategoryColorId, cc.ColorValue " +
                        "FROM Categories c " +
                        "INNER JOIN CategoryColors cc " +
                            "ON c.CategoryColorId = cc.Id";
            var result = _connection.Query<dynamic>(sql);
            Slapper.AutoMapper.Configuration.AddIdentifiers(typeof(Category), new List<string> { "Id" });
            Slapper.AutoMapper.Configuration.AddIdentifiers(typeof(CategoryColor), new List<string> { "CategoryColorId" });

            /*
             map
            */
            var output = (Slapper.AutoMapper.MapDynamic<Category>(result) as IEnumerable<Category>).ToList();
            foreach (var category in output)
            {
                category.CategoryColor = _connection.Query<CategoryColor>("SELECT * FROM CategoryColors where ID = "
                                                                                    + category.CategoryColorId).First();
            }

            return _mapper.Map<List<CategoryDto>>(output);
        }

        public List<Item> ListInventory()
        {
            var sql = $"SELECT i.Id, i.Name, i.Description, i.Notes, i.IsDeleted, i.CategoryId " +
                        ", c.Name as CategoryName" +
                        " FROM Items i INNER JOIN Categories c on i.CategoryId = c.Id" +
                        " WHERE i.IsDeleted = @isDeleted";
            var result = _connection.Query<dynamic>(sql, new { isDeleted = 0 });
            Slapper.AutoMapper.Configuration.AddIdentifiers(typeof(Item), new List<string> { "Id" });
            Slapper.AutoMapper.Configuration.AddIdentifiers(typeof(Category), new List<string> { "CategoryId" });

            var output = (Slapper.AutoMapper.MapDynamic<Item>(result) as IEnumerable<Item>).OrderBy(x => x.Name).ToList();

            //have to hydrate the relationship:
            foreach (var item in output)
            {
                item.Category = _connection.Query<Category>("SELECT * FROM Categories where ID = " + item.CategoryId).First();
            }
            return output;
        }
    }
}
