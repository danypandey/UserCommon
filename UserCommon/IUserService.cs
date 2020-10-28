using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace UserCommon
{
    [ServiceContract]
    public interface IUserService
    {
        /*
         * Get single row from database
         */
        [OperationContract]
        [WebGet(UriTemplate = "/users/{userid}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<Data> GetUserData(string userid);

        /*
         * Get all rows from database
         */
        [OperationContract]
        [WebGet(UriTemplate = "/users", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<Data[]> GetAllUsers();

        /*
         * Post single row in database
         */
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/users", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<Result> CreateUser(Data details);

        /*
         * Update single row in database
         */
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/users", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<Result> UpdateUser(Data details);

        /*
         * Delete single row in database
         */
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/users/{userid}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<Result> DeleteUser(string userid);

    }
}