var letterPause = 0.03;
 var word = "Test"; // change this one in the inspector
 private var currentWord = "";
 
 function Start ()
 {
     TypeText (word);
 }
 
 function AddText(newText : String)
 {
     word = newText;
     TypeText(word);
 }
 
 private function TypeText (compareWord : String) {
     for (var letter in word.ToCharArray()) {
         if (word != compareWord) break;
         currentWord += letter;
         yield WaitForSeconds(letterPause * Random.Range(0.5, 2));
     }  
 
 }
 
 function OnGUI()
 {
      GUI.Label(new Rect(100, 100, 200, 60), currentWord);
 }
