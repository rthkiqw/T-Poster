using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    public class PageControl
    {
        private static Authorization authorization;
        public static Authorization Authorization
        {
            get
            {
                if (authorization == null)
                    authorization = new Authorization();
                return authorization;
            }
        }
        private static Feed feed;
        public static Feed Feed
        {
            get
            {
                if (feed == null)
                    feed = new Feed();
                return feed;
            }
        }
    }
}
