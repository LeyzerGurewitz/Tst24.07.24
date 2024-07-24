using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tst.Model;
using static Tst.Configuration.TstConfiguration;
namespace Tst.Service
{
    internal static class TstService
    {
        public static void CreatXmlIfNoExist()
        {
            if (!File.Exists(tstPath))
            {
                XDocument document = new();
                XElement tst = new("Queries");
                document.Add(tst);
                document.Save(tstPath);
            }

        }
        public static void AddTst()
        {

            XDocument document = XDocument.Load(tstPath);

            XElement? queries = document.Descendants("Queries")
                .FirstOrDefault();
            if (queries == null) { return; }

            XElement Query = new XElement("Query");
            queries.Add(Query);
            document.Save(tstPath);
        }
        public static void AddtDey(string day)
        {

            XDocument document = XDocument.Load(tstPath);

            XElement? qurey = document.Descendants("Query")
                .FirstOrDefault();
            if (qurey == null) { return; }

            XElement da = new XElement("Day", day);
            qurey.Add(da);
            document.Save(tstPath);
        }
        public static void AddDeyMonth(int DayMonth)
        {

            XDocument document = XDocument.Load(tstPath);

            XElement? qurey = document.Descendants("Query")
                .FirstOrDefault();
            if (qurey == null) { return; }
            XElement dayM = new XElement("DayMonth", DayMonth);
            qurey.Add(dayM);
            document.Save(tstPath);

        }
        public static void AddMonth(string Month)
        {

            XDocument document = XDocument.Load(tstPath);

            XElement? qurey = document.Descendants("Query")
                .FirstOrDefault();
            if (qurey == null) { return; }
            XElement mont = new XElement("Month", Month);
            qurey.Add(mont);
            document.Save(tstPath);
        }
        public static void AddYear(string Year)
        {

            XDocument document = XDocument.Load(tstPath);

            XElement? qurey = document.Descendants("Query")
                .FirstOrDefault();
            if (qurey == null) { return; }
            XElement year = new XElement("Year", Year);
            qurey.Add(year);
            document.Save(tstPath);

        }
        public static void AddResult(string result)
        {

            XDocument document = XDocument.Load(tstPath);

            XElement? qurey = document.Descendants("Query")
                .FirstOrDefault();
            if (qurey == null) { return; }
            XElement year = new XElement("Result", result);
            qurey.Add(year);
            document.Save(tstPath);

        }
        //public static XElement ConvertTstToXElement(TstNodel tst) =>
        //     new XElement(
        //    "Query",
        //    new XElement("Day", tst.Day),
        //    new XElement("DayMonth", tst.DayMonth),
        //    new XElement("Month", tst.Month),
        //    new XElement("Year", tst.Year),
        //    new XElement("Result", tst.Result)
        //    );
        //public static void AddTst(TstNodel tst)
        //{
        //    XDocument document = XDocument.Load(tstPath);

        //    XElement? ts = document.Descendants("Queries")
        //        .FirstOrDefault();
        //    if (tst == null) { return; }
        //    ConvertTstToXElement(tst);
        //}

    }
}



