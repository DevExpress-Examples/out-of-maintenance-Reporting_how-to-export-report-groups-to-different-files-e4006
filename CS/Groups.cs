using System;
using System.Collections.Generic;
using System.Text;

namespace ExportGroups {
    public class Groups {
        public Groups(int startPageIndex, int endPageIndex) {
            this.startPageIndex = startPageIndex;
            this.endPageIndex = endPageIndex;
        }

        private int startPageIndex;
        private int endPageIndex;

        public int StartPageIndex {
            get { return startPageIndex; }
            set { startPageIndex = value; }
        }

        public int EndPageIndex {
            get { return endPageIndex; }
            set { endPageIndex = value; }
        }
    }
}
