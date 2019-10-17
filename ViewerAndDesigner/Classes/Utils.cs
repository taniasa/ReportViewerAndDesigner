using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewerAndDesigner.Classes
{
    public class DataReport
    {
        public DateTime Data { get; set; }
        public List<Data1> Data1 { get; set; }
        public List<Data1> Data2 { get; set; }
        public List<Data1> MyData3 { get; set; }

    }

    public class Utils
    {
        public static List<DataReport> Get()
        {
            var retorno = new DataReport();
            retorno.Data1 = GetData(1);
            retorno.Data2 = GetData(2);
            retorno.MyData3 = GetData(3);
            return new List<DataReport>() { retorno };
            
            //return retorno;
        }

        public static List<Data1> GetData(int id)
        {
            var data = new List<Data1>();
            for (int i = 1; i < 25; i++)
            {
                data.Add(new Data1(i, id, $"Name data {id} - {i.ToString()}"));
            }
            return data;
        }
    }

    public class Data1
    {
        public Data1(int id, int otherid, string name)
        {
            Id = id;
            OtherId = otherid;
            Name = name;
        }
        public int Id { get; set; }

        public int OtherId { get; set; }

        public string Name { get; set; }
    }
}