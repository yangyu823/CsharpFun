# C# Online Quiz Folder

## Goal

Implement a function FolderNames<br/>
which accepts a string containing an XML file that specifies folder structure <br/>
and returns all folder names that start with startingLetter.


* For example, for the letter 'u' and XML file:



## Provided code 
```C#
    public class Folders
    {
        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {
          //code here
        }

        public static void Main(string[] args)
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<folder name=\"c\">" +
                    "<folder name=\"program files\">" +
                        "<folder name=\"uninstall information\" />" +
                    "</folder>" +
                    "<folder name=\"users\" />" +
                "</folder>";

            foreach (string name in Folders.FolderNames(xml, 'u'))
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
```
### Output should be:
uninstall information
<br/>
users 


