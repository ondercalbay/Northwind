
using Northwind.MVCWebUI.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace Northwind.MVCWebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString Pager(PagingInfo pagingInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<ul class='pagination'>");
            for (int i = 1; i <= pagingInfo.TotalPage; i++)
            {
                sb.AppendFormat("<li {0}>", pagingInfo.CurrentPage == i ? "class='active'": "");
                var tagBuilder = new System.Web.Mvc.TagBuilder("a");
                tagBuilder.MergeAttribute("href", String.Format("http://localhost:52304/Product/index?{0}page={1}", pagingInfo.Query, i));
                tagBuilder.InnerHtml = i.ToString();

                sb.Append(tagBuilder);
                sb.AppendLine("</li>");
            }
            sb.AppendLine("</ul>");

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}