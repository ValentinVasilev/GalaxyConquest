#pragma checksum "D:\Важни\GitHubRepositories\GalaxyConquest\Web\GalaxyConquest.Web\Views\Home\Ranking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a98e17bad49099680fc69631e4150f93e56a0ef8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ranking), @"mvc.1.0.view", @"/Views/Home/Ranking.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Важни\GitHubRepositories\GalaxyConquest\Web\GalaxyConquest.Web\Views\_ViewImports.cshtml"
using GalaxyConquest.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Важни\GitHubRepositories\GalaxyConquest\Web\GalaxyConquest.Web\Views\_ViewImports.cshtml"
using GalaxyConquest.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a98e17bad49099680fc69631e4150f93e56a0ef8", @"/Views/Home/Ranking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db227bf04e69bc225d7e041e4f6029eabf8ccb45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ranking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GalaxyConquest.Web.ViewModels.Home.RankingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Важни\GitHubRepositories\GalaxyConquest\Web\GalaxyConquest.Web\Views\Home\Ranking.cshtml"
  
    this.ViewData["Title"] = "Rank List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""background-color:indianred"">
    <h1>Ranking page for all users!</h1>
    <div class=""row justify-content-center"">
        <table class=""table table-bordered table-hover table-responsive-md table table-striped col-md-6 table-primary"">
            <thead>
                <tr>
                    <th scope=""col"">
                        <span class=""fas fa-trophy""> Rank</span>
                        <span class=""fas fa-info-circle"" data-toggle=""tooltip"" data-placement=""top"" title=""
                              Place at the ranking list. Where #1 is the user with moste earned points by completing quizz's""
                             </span>
                    </th>
                    <th scope=""col"">
                        <span class=""fas fa-user-circle"">
                            Username
                            <span class=""fas fa-info-circle"" data-toggle=""tooltip"" data-placement=""top"" title=""
                             Name of the user that earned Quizz points.""
 ");
            WriteLiteral(@"                            </span>
                        </span>
                    </th>
                    <th scope=""col"">
                        <span class=""fas fa-star"">
                            Points
                            <span class=""fas fa-info-circle"" data-toggle=""tooltip"" data-placement=""top"" title=""
                              Total points earned from the user, by completeing Quizz.""
                             </span>
                        </span>
                    </th>
                    <th scope=""col"">
                        <span class=""fas fa-atom""> QuizzTaken</span>
                        <span class=""fas fa-info-circle"" data-toggle=""tooltip"" data-placement=""top"" title=""
                              Number of the quizzes that user have completed.""
                             </span>
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope=""row"">1</th>
       ");
            WriteLiteral("             <td>");
#nullable restore
#line 45 "D:\Важни\GitHubRepositories\GalaxyConquest\Web\GalaxyConquest.Web\Views\Home\Ranking.cshtml"
                   Write(Model.Rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "D:\Важни\GitHubRepositories\GalaxyConquest\Web\GalaxyConquest.Web\Views\Home\Ranking.cshtml"
                   Write(Model.Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "D:\Важни\GitHubRepositories\GalaxyConquest\Web\GalaxyConquest.Web\Views\Home\Ranking.cshtml"
                   Write(Model.QuizzTaken);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
                <tr>
                    <th scope=""row"">2</th>
                    <td>Jacob</td>
                    <td>145</td>
                    <td>9</td>
                </tr>
                <tr>
                    <th scope=""row"">3</th>
                    <td>Larry</td>
                    <td>142</td>
                    <td>10</td>
                </tr>
                <tr>
                    <th scope=""row"">4</th>
                    <td>Nasko</td>
                    <td>137</td>
                    <td>10</td>
                </tr>
                <tr>
                    <th scope=""row"">5</th>
                    <td>Pesho</td>
                    <td>136</td>
                    <td>10</td>
                </tr>
            </tbody>
        </table>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GalaxyConquest.Web.ViewModels.Home.RankingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
