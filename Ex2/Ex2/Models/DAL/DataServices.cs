using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex2.Models.DAL
{
    public class DataServices
    {
        static List<Episode> episodeList;

        public int Insert(Episode episode)
        {
            if (episodeList == null)
                episodeList = new List<Episode>();

            episodeList.Add(episode);
            return 1;
        }
        public List<Episode> Get()
        {
            return episodeList;
        }

        public List<Episode> Get(string seriesName)
        {
            List<Episode> filteredList = new List<Episode>();

            foreach (Episode e in episodeList)
            {
                if (e.SeriesName == seriesName)
                    filteredList.Add(e);
            }
            return filteredList;
        }
    }
}