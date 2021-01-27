using Amazon.Lambda.Core;
using HelpDeskService;
using HelpDeskService.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelpDesk.GetSupportIssues
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task<List<SupportIssue>> FunctionHandler(ILambdaContext context)
        {
            SupportService service = new SupportService(context);

            return await service.GetSupportIssuesAsync();
        }
    }
}
