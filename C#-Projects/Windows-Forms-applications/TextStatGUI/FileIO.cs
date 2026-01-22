using Microsoft.VisualBasic;

public class FileIO {

    public static void write(string filePath, string contents) {
        try {
            //Gets the directory path part from the filename
            string? directory = Path.GetDirectoryName(filePath);

            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory)) {
                Directory.CreateDirectory(directory);
            }
            // Opden the file for writing
            using (StreamWriter writer = new StreamWriter(filePath)) {
                // Write out to file
                writer.WriteLine(contents);
            } // end using


        } catch (UnauthorizedAccessException uae) {
            throw new UnauthorizedAccessException("You do not have permission to write to the specified file.", uae);
        } catch (IOException ioe) {
            throw new IOException("An input/output issue occured.", ioe);
        } catch (Exception ex) {
            throw new Exception( "An unexpected error has occured.", ex);
        }// end try
    }// end method

    public static List<string> Read(string filePath) {

        if (!File.Exists(filePath)) {
            throw new FileNotFoundException("The specified file does not exist.");
        }

        List<string> contents = new List<string>();

        try {
            using (StreamReader reader = new StreamReader(filePath)) {

                string? line;

                // This while the line is not null
                while ((line = reader.ReadLine()) != null) {
                    
                    // To the List contents we add the line 
                    contents.Add(line.Trim().ToLower());
                }// end while
            } // end using

        } catch (UnauthorizedAccessException uae) {
            throw new UnauthorizedAccessException("You do not have permission to read from the specified file.", uae);
        } catch (IOException ioe) {
            throw new IOException("An input/output issue occured.", ioe);
        } catch (Exception ex) {
            throw new Exception("An unexpected error has occured.", ex);
        }// end try

        return contents;
    }

    
}

