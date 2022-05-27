<<<<<<< HEAD
using System;
using UnityEngine;
using NotNull = JetBrains.Annotations.NotNullAttribute;

namespace Unity.Services.Core.Telemetry.Internal
{
    class ExponentialBackOffRetryPolicy
    {
        int m_MaxTryCount = 10;

        public int MaxTryCount
        {
            get => m_MaxTryCount;
            set => m_MaxTryCount = Math.Max(value, 0);
        }

        float m_BaseDelaySeconds = 2;

        public float BaseDelaySeconds
        {
            get => m_BaseDelaySeconds;
            set => m_BaseDelaySeconds = Math.Max(value, 0);
        }

        public bool CanRetry(WebRequest webRequest, int sendCount)
        {
            return sendCount < MaxTryCount
                && IsTransientError(webRequest);
        }

        public static bool IsTransientError(WebRequest webRequest)
        {
            return webRequest.Result == WebRequestResult.ConnectionError
                || webRequest.Result == WebRequestResult.ProtocolError && IsServerErrorCode(webRequest.ResponseCode);

            bool IsServerErrorCode(long responseCode)
            {
                return responseCode >= 500
                    && responseCode < 600;
            }
        }

        public float GetDelayBeforeSendingSeconds(int sendCount)
        {
            if (sendCount <= 0)
            {
                return BaseDelaySeconds;
            }

            return Mathf.Pow(BaseDelaySeconds, sendCount);
        }
    }
}
=======
using System;
using UnityEngine;
using NotNull = JetBrains.Annotations.NotNullAttribute;

namespace Unity.Services.Core.Telemetry.Internal
{
    class ExponentialBackOffRetryPolicy
    {
        int m_MaxTryCount = 10;

        public int MaxTryCount
        {
            get => m_MaxTryCount;
            set => m_MaxTryCount = Math.Max(value, 0);
        }

        float m_BaseDelaySeconds = 2;

        public float BaseDelaySeconds
        {
            get => m_BaseDelaySeconds;
            set => m_BaseDelaySeconds = Math.Max(value, 0);
        }

        public bool CanRetry(WebRequest webRequest, int sendCount)
        {
            return sendCount < MaxTryCount
                && IsTransientError(webRequest);
        }

        public static bool IsTransientError(WebRequest webRequest)
        {
            return webRequest.Result == WebRequestResult.ConnectionError
                || webRequest.Result == WebRequestResult.ProtocolError && IsServerErrorCode(webRequest.ResponseCode);

            bool IsServerErrorCode(long responseCode)
            {
                return responseCode >= 500
                    && responseCode < 600;
            }
        }

        public float GetDelayBeforeSendingSeconds(int sendCount)
        {
            if (sendCount <= 0)
            {
                return BaseDelaySeconds;
            }

            return Mathf.Pow(BaseDelaySeconds, sendCount);
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
