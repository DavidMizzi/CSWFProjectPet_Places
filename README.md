README

Project: Pet Places

TABLE OF CONTENTS
-----------------

1. Introduction
2. Project Scope
3. Programming Features and Limitations
4. Requirements
5. Installation
6. Licensing
7. Running the Program
8. Developer Contact


INTRODUCTION
------------

Pet Places ('the app') is a Windows Forms application developed in C# and which utilises the 
.NET framework. Associated with the Windows Forms program is a mutually reliant SQL database.

The app has been developed as a learning project intended to test the developer's capacity to
develop a C# app (with considerable online tutorial support) and to develop a corresponding
SQL database with simplistic CRUD functioning. 


PROJECT SCOPE
-------------

Pet Places is limited in its scope to what would be an amateur proof of concept of a functioning
app which enables users to create, read, update and delete local pet data onto a database in a
user-friendly (non-coding) fashion.

Development time was approximately 23 hours of learning and programming.


PROGRAMMING FEATURES and LIMITATIONS
------------------------------------

Programming features of the app include but are not limited to:

* Database connectivity
* CRUD functionality from the application
* Conditions
* Various other programming concepts and methods

Noteworthy limitations to the app include:

* Window resizing is disabled owing to the graphic art background being of insufficient 
  resolution during screen maximisation.
 
* Searching function is limited to searching by pet type only. Future programs based on this
  concept will entail enhanced search features.

* There is no cancel function button as the screen close function employs this feature. Such a
  function would be encompassed within any similar programs to enhance user experience.


REQUIREMENTS
------------

Recommended Requirements:

* Visual Studio 2022
* XAMPP Control Panel v3.3.0
* Windows 10
* 1.8 GHz or faster 64-bit processor; Quad-core or better recommended. ARM processors are not 
  supported.
* 16 GB of RAM
* Hard disk space: if Visual Studio already installed - 100KB, if Visual Studio not already 
  installed - 1GB.
* Video Card with resolution capability of 1920 x 1080 or higher.


INSTALLATION
------------

Installation is provided in two stages.

Stage 1 - Installation of Application
* Install Visual Studio 2022 (see 'REQUIREMENTS' header)
* Open Visual Studio
* Select 'Clone a repository'
* On the 'Enter a Git repository URL' screen, input the following:
  https://github.com/DavidMizzi/CSWFProjectPet_Places.git
* Click the 'Clone' button in the bottom right of the screen
* If you experience any issues accessing the program, please contact the developer whose details
  are found under the 'Developer Contact' header.

Stage 2 - Installation of database and data download
* Access the following link:
* https://github.com/DavidMizzi/CSWFProjectPet_Places.git
* Open file: mysql_pet_places.sql
* Transfer SQL code to your locally installed DBMS (Database Management System) such as phpMyAdmin


RUNNING the PROGRAM
-------------------

* After following the directions in the 'Installation' header, utilise the specific method of your
  local database software to:
  a. ensure username is: root
  b. ensure port is: 3306
  c. ensure the DBMS has not got passwords enabled for the mysql_pet_places database

* If you are utilising XAMPP Control Panel v3.3.0:
  a. The default username established during installation of XAMPP is 'root'. If you have modified your
     username at anytime, the username will have to be reverted back to root in order for the app to
     establish a connection with your database. 

     XAMPP username can be modified in the following manner:
	1. Enter the following into your internet browser url:
		http://localhost/phpmyadmin/
	2. Sign into phpMyAdmin if requested to do so
	3. Select 'User Accounts' tab
	4. The 'Host name' must be: localhost (if host name is not localhost see point 6 for resolution)
	5. The 'User name' must be: root (if host name is not localhost see point 6 for resolution)
	6. If host name or user name are not as specified, click on the user name
	7. Click on the 'Login Information' tab
	8. Amend the host name and/or user name accordingly
     	
  b. To modify port to 3306:
  	1. Open XAMPP application
	2. Click 'Config' on the top right of the application to open the Configuration of Control Panel
	3. Select 'Service and Port Settings' in the Configuration of Control Panel
	4. Select the 'MySQL' tab
	5. In the 'Main Port' box insert: 3306
	6. Click Save

* Prior to running the app in Visual Studio, ensure that the DBMS running port 3306 is actioned and 
  running. If you are utilising XAMPP Control Panel v3.3.0, this is done by:
	1. Open XAMPP application
	2. Click Start for the 'Apache' module
	3. Click Start for the 'MySQL' module

* Open Visual Studio, select and open WFLearning1.FormPet and use Ctrl + F5 to run the program.


LICENSING
---------

The app and the data contained therein are the property of the developer as identified under the
'Developer Contact' header in this README file. 

The app and the data contained therein are licensed to be used, copied and replicated for both
educational and non-commercial purposes only however, the developer must be credited in accordance
to this license.

Any licensing which falls outside of the aforementioned parameters remain athe the sole and express
discretion of the developer.

For any queries, contact the developer.

DEVELOPER CONTACT
-----------------

Name: David Mizzi
Email: david.mizzi@outlook.com
Contact number: +61 466 080 594
