using System;

namespace TextGame{
    class SaveGame{
        public static async Task Save(){
            string testy = "Test line to write";

            using StreamWriter file = new("WriteLinesTest.txt");

            await file.WriteLineAsync(testy);
        }
    }
}
