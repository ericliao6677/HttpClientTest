using HttpClientTest.Domain.Enum;

namespace HttpClientTest.Domain.Dtos.Response
{
    public record ResultResponse(
        ReturnCodeEnum ReturnCode = ReturnCodeEnum.Success
        ,string ReturnMessage = ""
        ,object? ReturnData = default);
}
