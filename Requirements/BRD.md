### Windows app that can search for a string in a textfile, and replace or add more text.

Phase 1: Windows app that can select a text file, search for a provided string in the file, and replace or delete the provided text.

- Steps towards development 
	- Write Requirements for Phase 1.
	- Design the application UI.
	- Implement functionalities as per the requirements.
	
- Requirements for Phase 1
	- A file selector.
	- Two string inputs.
	- File reader.
	- Searcher of stringA.
	- Lables for Count and Positions of stringA in the file.
	- Replacing of stringA with either blank string, or with stringB, as per the user request.
	
- Design for Phase 1
	- Lable1	: "Select file:"
	- Picker1	: *File Selector*
	- Lable2	: "Enter string to search:"
	- TextArea1	: *Area to enter lengthy stringA*
	- Lable3	: "Enter string to replace the above entered string:"
	- TextArea2	: *Area to enter lengthy stringB*
	- Button1	: "Submit" - *Success of this button will show the below UI*
	- Lable4	: "Count of stringA found in File:"
	- Lable5	: *Show count of stringA found in File*
	- Lable6	: "Positions of stringA found in File:"
	- Lable7	: *Show Positions of stringA found in File*
	- Lable8	: "Replace all occurences of stringA in File?"
	- Button2	: "Replace"
	- Lable9	: *Show if the program succeeded*
	- Progress	: *Show a progress bar/ processing/ loading icon*