using HttpClientTest.Domain.Enum;
using System.Net;

namespace HttpClientTest.Domain.Dtos.Response
{
    public class ResultResponseExtension
    {
        public class Query
        {
            public static ResultResponse QuerySuccess(object? returnData) =>
                new ResultResponse(ReturnMessage: "查詢成功", ReturnData: returnData);
            public static ResultResponse QueryNotFound(HttpStatusCode remoteServerReturnCode) =>
                new ResultResponse(ReturnCode: ReturnCodeEnum.QueryNotFound, ReturnMessage: $"查詢失敗，狀態碼: {remoteServerReturnCode}");
                
        }

    }
}
