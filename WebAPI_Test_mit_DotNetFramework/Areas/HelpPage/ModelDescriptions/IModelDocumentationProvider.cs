using System;
using System.Reflection;

namespace WebAPI_Test_mit_DotNetFramework.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}