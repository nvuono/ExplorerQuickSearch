using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace QuickSearch
{
    public class SearchMsGenerator
    {
        // Some defaults initialized here...
        // We can customize these later by passing in options, etc

        private string GUID_MyComputer = "{20D04FE0-3AEA-1069-A2D8-08002B30309D}";

        private IList<UnionKinds> kinds = new List<UnionKinds>() { UnionKinds.Item };
        
        private IList<DesktopSearchProperties> sortPropList = 
            new List<DesktopSearchProperties>() { 
                DesktopSearchProperties.System_Search_Rank, 
                DesktopSearchProperties.System_DateModified, 
                DesktopSearchProperties.System_ItemNameDisplay };
        private IList<string> sortOrderList = new List<string>() { "descending", "descending", "ascending" };

       private IList<DesktopSearchProperties> VisibleColumnList = new List<DesktopSearchProperties>() { 
                DesktopSearchProperties.System_ItemNameDisplay,
                DesktopSearchProperties.System_DateModified, 
                DesktopSearchProperties.System_ItemTypeText,
                DesktopSearchProperties.System_Size, 
                DesktopSearchProperties.System_ItemFolderPathDisplay};


        /// <summary>
        /// Generates the XDocument needed to create a .search-ms file for the path and mask given.
        /// 
        /// There are additional customizations we can add later on...
        ///   (look at the private collections within the SearchMsGenerator class for details)
        /// </summary>
        /// <param name="searchPath"></param>
        /// <param name="searchMask"></param>
        /// <returns></returns>
        public XDocument GenerateSearchDoc(string searchPath, string searchMask)
        {
            var x = new System.Xml.Linq.XElement("persistedQuery");

            XDocument doc = null;
            doc = new XDocument(
                 new XDeclaration("1.0", "utf-8", "yes"),
                 new XElement("persistedQuery", new XAttribute("version", "1.0"),
                     generateViewInfo(searchPath),
                     new XElement("query",
                         generateConditions(searchMask),
                         generateKindList(this.kinds),
                         generateScope(searchPath)),
                     new XElement("properties")));

            return doc;
        }

        /// <summary>
        /// These elements define the union of the "kind" of items that should appear in the library
        /// </summary>
        /// <param name="kind"></param>
        /// <returns></returns>
        XElement generateKindList(IEnumerable<UnionKinds> kindList)
        {
            XElement retVal = new XElement("kindList");

            foreach (UnionKinds myKind in kindList)
            {
                retVal.Add(new XElement("kind",
                        new XAttribute("name", myKind.ToString().ToLowerInvariant())));
            }
            return retVal;
        }

        /// <summary>
        /// This was a lot more convoluted in the automatically generated windows file... 
        /// According to http://msdn.microsoft.com/en-us/library/windows/desktop/bb892885%28v=vs.85%29.aspx docs we can make this much simpler
        /// </summary>
        /// <param name="fileMask"></param>
        /// <returns></returns>
        XElement generateConditions(string fileMask)
        {
            string fileMaskAdjusted = fileMask.Replace("*", ""); //asterisks are stripped from some but not all

            XElement retVal = new XElement("conditions", new XElement("condition", new XAttribute("type", "leafCondition"), new XAttribute("property", "System.FileExtension"), new XAttribute("operator", "starts with"), new XAttribute("propertyType", "string"), new XAttribute("value", fileMaskAdjusted), new XAttribute("localeName", "en-US"),
                new XElement("attributes", new XElement("attribute", new XAttribute("attributeID", "{9554087B-CEB6-45AB-99FF-50E8428E860D}"), new XAttribute("clsid", "{C64B9B66-E53D-4C56-B9AE-FEDE4EE95DB1}"), new XAttribute("chs", "1"), new XAttribute("sqro", "585"), new XAttribute("timestamp_low", "2509422630"), new XAttribute("timestamp_high", "30259757"),
                    new XElement("condition", new XAttribute("type", "leafCondition"), new XAttribute("property", "System.FileExtension"), new XAttribute("operator", "starts with"), new XAttribute("propertyType", "string"), new XAttribute("value", fileMaskAdjusted), new XAttribute("localeName", "en-US"),
                        new XElement("attributes", new XElement("attribute", new XAttribute("attributeID", "{9554087B-CEB6-45AB-99FF-50E8428E860D}"), new XAttribute("clsid", "{C64B9B66-E53D-4C56-B9AE-FEDE4EE95DB1}"), new XAttribute("chs", "1"), new XAttribute("sqro", "585"), new XAttribute("timestamp_low", "2305812271"), new XAttribute("timestamp_high", "30259757"),
                            new XElement("condition", new XAttribute("type", "leafCondition"), new XAttribute("property", ""), new XAttribute("operator", "imp"), new XAttribute("propertyType", "string"), new XAttribute("value", fileMask + " 0000 0000 0000 0001 0002 0003 N F"), new XAttribute("valuetype", "System.StructuredQueryType.FilePath"), new XAttribute("localeName", "en-US"),
                                new XElement("attributes", new XElement("attribute", new XAttribute("attributeID", "{9554087B-CEB6-45AB-99FF-50E8428E860D}"), new XAttribute("clsid", "{C64B9B66-E53D-4C56-B9AE-FEDE4EE95DB1}"), new XAttribute("chs", "0"), new XAttribute("timestamp_low", "2305812271"), new XAttribute("timestamp_high", "30259757"))
                                )
                                )
                                )))))));


            return retVal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchPath"></param>
        /// <returns></returns>
        XElement generateViewInfo(string searchPath)
        {
            XElement retVal = new XElement("viewInfo", new XAttribute("iconSize", "32"), new XAttribute("stackIconSize", "0"),
                new XAttribute("displayName", "Search Results in " + searchPath), new XAttribute("autoListFlags", "0"),
                generateVisibleColumns(VisibleColumnList),
                generateSortList(sortPropList,sortOrderList));
            return retVal;
        }

        /// <summary>
        /// Determines what the sort order of items will be--
        /// the list of orders (ascending/descending) is optional and will default to descending
        /// </summary>
        /// <param name="props"></param>
        /// <param name="orders"></param>
        /// <returns></returns>
        XElement generateSortList(IEnumerable<DesktopSearchProperties> props, IEnumerable<string> orders = null)
        {
            /*"<sortList>" +
            "<sort viewField=\"System.Search.Rank\" direction=\"descending\"/>" +
            "<sort viewField=\"System.DateModified\" direction=\"descending\"/>" +
            "<sort viewField=\"System.ItemNameDisplay\" direction=\"ascending\"/>" +
            "</sortList>"*/
            string orderDirection = "descending"; // default is just descending order for everything
            XElement retVal = new XElement("sortList");

            IEnumerator<string> orderEnumerator = null;
            if (orders != null)
            {
                orderEnumerator = orders.GetEnumerator();
            }

            foreach (DesktopSearchProperties prop in props)
            {
                if (orderEnumerator != null && orderEnumerator.MoveNext())
                {
                    orderDirection = orderEnumerator.Current;
                }
                else
                {
                    // do we want to break here if they don't pass in ordering parameters for everything?
                }
                new XElement("sort", new XAttribute("viewField", prop.GetDescription()), new XAttribute("direction", orderDirection));
            }

            return retVal;
        }

        /// <summary>
        /// Can expand this in the future
        /// </summary>
        /// <returns></returns>
        XElement generateVisibleColumns(IList<DesktopSearchProperties> props)
        {
            /*"<visibleColumns>"+
            "<column viewField=\"System.ItemNameDisplay\"/>"+
            "<column viewField=\"System.DateModified\"/>"+
            "<column viewField=\"System.ItemTypeText\"/>"+
            "<column viewField=\"System.Size\"/>"+
            "<column viewField=\"System.ItemFolderPathDisplay\"/>"+
            "</visibleColumns>" */

            XElement retVal = new XElement("visibleColumns");

            foreach(var prop in props){
                retVal.Add(new XElement("column", new XAttribute("viewField", prop.GetDescription())));
            }
                
            return retVal;
        }

        /// <summary>
        /// The scope element identifies the locations to include or exclude from the search. 
        /// The scope element must contain at least one 'include' child element present 
        /// and zero or more 'exclude' elements. 
        /// 
        /// The locations can be specified as either a path (environment variables are supported) 
        /// or as a known folder identifier. 
        /// 
        /// Furthermore, each of these locations can be specified to be searched deep or shallow 
        /// by setting the nonRecursive to "true" or "false" (default is recursive). 
        /// Parts of the included list of locations can be excluded by specifying exclude elements.
        /// </summary>
        /// <returns></returns>
        XElement generateScope(string searchPath)
        {
            /*<scope>
               <include knownFolder="{FDD39AD0-238F-46AF-ADB4-6C85480369C7}" nonRecursive="true"/>
               <include path="E:\"/>
               <exclude path="E:\Windows" nonRecursive="false"/>
            </scope>*/

            /*"<scope>" +
                 "<include path=\"::{20D04FE0-3AEA-1069-A2D8-08002B30309D}\\C:\\BOXI_Incoming\" attributes=\"1887437183\"/>" +
              "</scope>";*/

            XElement ret = new XElement("scope", new XElement("include",
                new XAttribute("path", "::" + GUID_MyComputer + "\\" + searchPath),
                new XAttribute("attributes", "1887437183"))); // I have no idea what this attributes value indicates
            return ret;
        }
    }
}
