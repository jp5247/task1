using System.Text;

string OutputFileName = @"index.html";
string headFileName = @"header.txt";
string closingFileName = @"footer.txt";

try
{
    if (File.Exists(OutputFileName))
    {
        File.Delete(OutputFileName);
    }

    string head = ReadData(headFileName);
    string closing = ReadData(closingFileName);

    using (StreamWriter sw = File.CreateText(OutputFileName))
    {
        sw.WriteLine(head);
        sw.WriteLine(generateBoard());
        sw.WriteLine(closing);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

string ReadData(string fileName)
{
    //using (StreamReader sr = File.OpenText(fileName))
    //{
    //    string s = "";
    //    while ((s = sr.ReadLine()) != null)
    //    {
    //        if (s != null)
    //        {
    //            s += s;
    //        }
    //    }
    //    return s;
    //}
    string s = File.ReadAllText(fileName);
    return s;
}

string generateBoard()
{
    StringBuilder sb = new StringBuilder();

    // create table
    sb.AppendLine("<table class=\"chess-board\">");

    // table body start
    sb.AppendLine("<tbody>");

    // table heading a - h
    sb.AppendLine("<tr><th></th><th>a</th><th>b</th><th>c</th><th>d</th><th>e</th><th>f</th><th>g</th><th>h</th></tr>");

    // main board with number 8-1
    for (int i = 8; i > 0; i--)
    {
        sb.AppendLine("<tr>\n<th>" + i + "</th>");
        for (int j = 8; j > 0; j--)
        {
            if ((i + j) % 2 == 0)
            {
                sb.AppendLine("<td class=\"light\"></td>");
            }
            else
            {
                sb.AppendLine("<td class=\"dark\"></td>");
            }
        }
        sb.AppendLine("</tr>");
    }
    return sb.ToString();
}