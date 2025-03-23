d => !userDigits.Contains(d);

string allDigits = "123456789";
HashSet<char> userDigits = new() { '1', '3', '5' };

var missingDigits = allDigits.Where(d => !userDigits.Contains(d));
