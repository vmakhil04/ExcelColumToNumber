class Program  
    {          
        
        private static int ExcelColumnNameToNumber(string columnName)
{
    if (string.IsNullOrEmpty(columnName)) throw new ArgumentNullException("columnName");

    columnName = columnName.ToUpperInvariant();

    int sum = 0;

    for (int i = 0; i < columnName.Length; i++)
    {
        sum *= 26;
        sum += (columnName[i] - 'A' + 1);
    }

    return sum;
}
        
        static void Main(string[] args)  
        {  
            string column;  
            Console.WriteLine("please enter the excel column");  
            column =(Console.ReadLine());
           int value= ExcelColumnNameToNumber(column);
           Console.WriteLine("Column value is :" + value.ToString());   
           
        }  
    }