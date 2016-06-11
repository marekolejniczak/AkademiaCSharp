using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class TeleBook
    {
       public ObservableCollection<NormalContact> TeleBookCollection { get; set; }
    }
}
