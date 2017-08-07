# DiReCT
Today, disaster historical records are typically written in natural language text together with tables, graphs, etc. In their current form, disaster records have two shortcomings. Data and information may be inconsistent and incomplete, and such defects take time and effort to uncover.

Mobile Disaster Record Capture Tool (DiReCT) is used by trained professionals to capture and record observational data during disasters and emergencies. Disaster records produced with the help of the system can be read and processed by search, analysis, simulation and visualization tools for purposes such as developing better response strategies, providing decision support during emergencies, post-disaster analysis, and so on.

## Set up
### 1. Build Direct UI
Since the GUI is a separated solution from the Core, the program will need to make sure GUI is built before loading the entire program. To do so, simply open the DiReCT solution inside /DiReCTUI/DiReCT/ in Visual Studio and build all projects under "Build". However, you will need to make sure all references exist in the solution. Currently only the Bing Map has to be manually download and reference. You can find it in the link here: https://www.microsoft.com/en-us/download/details.aspx?displaylang=en&id=27165 . 

### 2. Build the Record Class
Because all the record class will be loaded from dll files, those files must be saved in DiReCT/bin/Debug folder. To build the record class to dll file, open the solution in the main folder. By right click on the record class project (for example, SOPFlood), click build and VS will automatically create dll files inside the project's bin/Debug folder (ex: SOPFlood/bin/Debug). Now, you will have to move the dll file to DiReCT/bin/Debug so that the main program can load it.

After the set up, the program should be able to start correctly.
