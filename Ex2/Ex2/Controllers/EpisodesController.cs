using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ex2.Models;

namespace Ex2.Controllers
{
    public class EpisodesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            Episode e = new Episode();
            List<Episode> Elist = e.Get();//קבלת הרשימה של הפרקים
            List<string> seriesList = uniqueSeries(Elist);
            return seriesList;
        }

        // GET api/<controller>/5
        public IEnumerable<Episode> Get(string seriesName)
        {
            Episode e = new Episode();
            List<Episode> Elist = e.Get(seriesName);
            return Elist;
        }

        // POST api/<controller>
        public int Post([FromBody]Episode e)
        {
            e.Insert();
            return 1;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        private List<string> uniqueSeries(List<Episode> list)
        {
            string[] arr = new string[list.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = list[i].SeriesName;
            }
            List<string> distinctList = arr.Distinct().ToList();
            return distinctList;
        }
    }
}