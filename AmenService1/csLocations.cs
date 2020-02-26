using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csLocations
    {
        csDAL objdal = new csDAL();

        //-------------Location---------------
        public int Continent_ID { set; get; }
        public string Continent_Name { set; get; }
        public string Country_Name { set; get; }
        public string Country_Flag { set; get; }


       public csLocations()
        { }

       public DataTable viewCountriesByContinent_ID(int Continent_ID)
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           List<csParameterListType> objpar = new List<csParameterListType>();
           objpar.Add(new csParameterListType("@Continent_ID", SqlDbType.BigInt, Continent_ID));
           dt = objdal.search("procCountriesByContinent_ID", objpar);
           return dt;
       }


       public DataTable viewAllCountries()
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           dt = objdal.search("procCountries_ViewAll");
           return dt;
       }


       public DataTable viewAllContinents()
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           dt = objdal.search("procContinents_ViewAll");
           return dt;
       }

       public DataTable viewAllProvincies_By_Country()
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           dt = objdal.search("procProvinces_By_Country");
           return dt;
       }

       public DataTable viewProvinciesByCountry_ID(int Country_ID)
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           List<csParameterListType> objpar = new List<csParameterListType>();
           objpar.Add(new csParameterListType("@Country_ID", SqlDbType.BigInt, Country_ID));
           dt = objdal.search("procProvinces_By_Country", objpar);
           return dt;
       }

       public DataTable viewAllCities()
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           dt = objdal.search("procCities_ViewAll");
           return dt;
       }
    }
}
