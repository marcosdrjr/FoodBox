using FoodBoxLibrary.Models.DTOS;
using FoodBoxApi.Business.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoodBoxApi.Business.Implemetations
{
    public class SnacksServices : ISnacksServices
    {
        public async Task<List<SnacksDTO>> GetSnacks()
        {
            var listSnacks = new List<SnacksDTO>();
            listSnacks.Add(new SnacksDTO {id_snacks = 1, name = "1", description = "01" });
            listSnacks.Add(new SnacksDTO {id_snacks = 2, name = "2", description = "02" });
            listSnacks.Add(new SnacksDTO {id_snacks = 3, name = "3", description = "03" });
            listSnacks.Add(new SnacksDTO {id_snacks = 4, name = "4", description = "04" });
            listSnacks.Add(new SnacksDTO {id_snacks = 5, name = "5", description = "05" });

            //_settings.ConnectionString
            var ConnectionString = "";
            using (var connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();
                var selectSql = @$" select 
                                    cdt_id_create_account as ""idAccount"",
                                    bank_account_digit as ""bankAccountDigit"",
                                    bank_branch_digit as ""bankBranchDigit"",
                                    bank_number as ""bankNumber"",
                                    bank_account_number as ""bankAccountNumber"",
                                    bank_branch_number as ""bankBranchNumber"",
                                    is_alias_bank_accounts as ""IsAliasBankAccounts""
                                    from account
                                    WHERE is_alias_bank_accounts = 1
                                    and cdt_id_create_account = @cdt_id_create_account ";
                var ret = await connection.QueryAsync<SnacksDTO>(selectSql);
              //  return ret;
            }

            return listSnacks;
        }


    }
}
