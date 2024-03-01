using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.FileAccess;
public interface IFileWriter
{
    void Write(
        string content, params string[] pathParts);
}