using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using DALayer;

namespace ProductionHouseUI
{
    /// <summary>
    /// Summary description for ProductionHouseService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ProductionHouseService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetProducerList()
        {
            string cs = "Integrated Security =sspi; database=ProductionHouse; server=PACL5XS5AL\\SQLEXPRESS";
            //string cs = ConfigurationManager.ConnectionStrings["ProductionHouseEntities"].ConnectionString;
            List<ProducerEntity> Producers = new List<ProducerEntity>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetProducerList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    ProducerEntity producerEntity = new ProducerEntity();
                    producerEntity.Producer_Id = Convert.ToInt32(rdr["Producer_Id"]);
                    producerEntity.Producer_Name = rdr["Producer_Name"].ToString();
                    Producers.Add(producerEntity);
                }
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            string JsonData = js.Serialize(Producers);
            return JsonData;
        }
        [WebMethod]
        public string GetActorList()
        {
            string cs = "Integrated Security =sspi; database=ProductionHouse; server=PACL5XS5AL\\SQLEXPRESS";
            //string cs = ConfigurationManager.ConnectionStrings["ProductionHouseEntities"].ConnectionString;
            List<ActorEntity> Actors = new List<ActorEntity>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetActorList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ActorEntity actorEntity = new ActorEntity();
                    actorEntity.Actor_Id = Convert.ToInt32((rdr["Actor_Id"]));
                    actorEntity.Actor_Name = rdr["Actor_Name"].ToString();
                    Actors.Add(actorEntity);
                }
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            string JsonData = js.Serialize(Actors);
            return JsonData;
        }
    }
}
