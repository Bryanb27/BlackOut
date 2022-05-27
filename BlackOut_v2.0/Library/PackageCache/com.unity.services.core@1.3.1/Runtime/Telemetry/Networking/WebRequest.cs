<<<<<<< HEAD
namespace Unity.Services.Core.Telemetry.Internal
{
    enum WebRequestResult
    {
        Success,
        ConnectionError,
        ProtocolError,
        UnknownError,
    }

    struct WebRequest
    {
        public WebRequestResult Result;

        public string ErrorMessage;

        public string ErrorBody;

        public long ResponseCode;

        public bool IsSuccess => Result == WebRequestResult.Success;
    }
}
=======
namespace Unity.Services.Core.Telemetry.Internal
{
    enum WebRequestResult
    {
        Success,
        ConnectionError,
        ProtocolError,
        UnknownError,
    }

    struct WebRequest
    {
        public WebRequestResult Result;

        public string ErrorMessage;

        public string ErrorBody;

        public long ResponseCode;

        public bool IsSuccess => Result == WebRequestResult.Success;
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
