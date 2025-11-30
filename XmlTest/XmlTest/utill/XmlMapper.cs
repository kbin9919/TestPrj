using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlTest.utill
{
    public abstract class XmlMapper
    {
        private readonly Dictionary<string, string> _queries = new Dictionary<string, string>();

        public XmlMapper(string xmlFilePath)
        {
            Load(xmlFilePath);
        }

        private void Load(string xmlFilePath)
        {
            var doc = XDocument.Load(xmlFilePath);

            foreach (var node in doc.Descendants("query"))
            {
                string id = node.Attribute("id")!.Value;
                string sql = node.Value.Trim();
                _queries[id] = sql;
            }
        }

        public string GetQuery(string id)
        {
            if (!_queries.ContainsKey(id))
            {
                throw new KeyNotFoundException($"쿼리 ID '{id}'가 존재하지 않음");
            }
            return _queries[id];
        }
    }
}
