﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise03 {
    class SalesCounter {
        private IEnumerable<Sale> _sales; //csvファイルから読み込んだデータ

        //コンストラクタ
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }
        //店舗別売り上げを求める
        public Dictionary<string, int> GetPerStoreSales()
        {
            var dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }

        //商品別売り上げ
        public Dictionary<string, int> GetPerProductSales()
        {
            var dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales)
            {
                if (dict.ContainsKey(sale.ProductCategory))
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        }

        public static IEnumerable<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            String[] lines = File.ReadAllLines(filePath);
            foreach (String line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}