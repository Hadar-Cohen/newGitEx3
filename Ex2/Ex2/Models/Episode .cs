using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ex2.Models.DAL;

namespace Ex2.Models
{
    public class Episode
    {
        string seriesName;
        int seasonNum;
        string episodeName;
        string imageURL;
        string overview;
        string airDate;

        public string SeriesName { get => seriesName; set => seriesName = value; }
        public int SeasonNum { get => seasonNum; set => seasonNum = value; }
        public string EpisodeName { get => episodeName; set => episodeName = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public string Overview { get => overview; set => overview = value; }
        public string AirDate { get => airDate; set => airDate = value; }

        public Episode()
        {

        }

        
        public int Insert()
        {
            DataServices ds = new DataServices();
            ds.Insert(this);
            return 1;
        }

        public List<Episode> Get()
        {
            DataServices d = new DataServices();
            List<Episode> episodeList = d.Get();
            return episodeList;
        }
        public List<Episode> Get(string seriesName)
        {
            DataServices d = new DataServices();
            List<Episode> Flist = d.Get(seriesName);
            return Flist;
        }
    }
}