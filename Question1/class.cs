//Question 1 
//Taking the following EDIFACT message text, write some code to parse out the all the LOC
//segments and populate an array with the 2 nd and 3 rd element of each segment.
void Main()
{
    // EDIFACT message text
    string edifact = @"UNA:+.? &#39'
        UNB+UNOC:3+2021000969+4441963198+180525:1225+3VAL2MJV6EH9IX+KMSV7HMD+CUSDECU-
        IE++1++1&#39'
        UNH+EDIFACT+CUSDEC:D:96B:UN:145050&#39'
        BGM+ZEM:::EX+09SEE7JPUV5HC06IC6+Z&#39'
        LOC+17+IT044100&#39'
        LOC+18+SOL&#39'
        LOC+35+SE&#39'
        LOC+36+TZ&#39'
        LOC+116+SE003033&#39'
        DTM+9:20090527:102&#39'
        DTM+268:20090626:102&#39'
        DTM+182:20090527:102&#39'";
 
    //array
    List <> results = new List <>();
 
    // split on newline, then select lines starting with LOC+ 
    string[] loc = edifact.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
        .Where(loc => loc.StartsWith("LOC+")).ToArray();
  
    foreach (string loc in locs)
    {
        // remove ' 
        string trimmedLine = line.Substring(0, line.IndexOf('\''));
 
        // split on the + 
        string[] items = trimmedLine.Split('+').ToArray();
 
        // add items 1 and 2 to the results list 
        results.Add(new Tuple(items[1], items[2]));
    }
}