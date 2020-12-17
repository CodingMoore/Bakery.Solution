# **bakery.Solution**
Project Initiated: 2020-12-11<br>
Updated: 2020-12-16
## **Project Description**
This project is a console-based user interface for purchasing various baked goods.  When the program prject is initiated, the user is greeted and offerd several menu choices.  The user is free to navigate the menus and update their shopping cart with the goods that they wish to purchase.

Since the bakery is having a sale, prices are calculated based on how many of each type of product are in the cart.  Bread is noramally $5 a loaf, but is "Buy 2 get one free".  Pastries are normally $2 each, but you can get 3 for $5. The price of all goods, including the sale prices, are continuously tallied for the user.  If the user has earned a free loaf of bread but has not added it to their cart, the user is notified at the time of the purchase.

This is my first solo c# project, and is an exercise in coding using C# and .NET, using Test Driven Development, classes, getters and setters, apropriate file structures, etc. 
## **Required for Use**
* C# and .Net Core installed on your local machine. (Developed on .Net Core v2.2.4)
* Console/Terminal access.
## **Installation Instructions**
Dowload .Net Core from the following link and follow the installation instructions.
https://dotnet.microsoft.com/download

**Option 1** (download zip file)
1) Copy and paste the following GitHub project link into your web browser's url bar and hit enter/return. https://github.com/RMGit-it/Bakery.Solution

2) Download a .zip copy the repository by clicking on the large green "Code" button near the upper right corner of the screen.
3) Right click the .zip file and extract(unzip) it's contents.
4) Open your computer's terminal/console, and navigate to folder called "__bakery__". 
5) Once there, type the following code and hit enter/return to install the necessary dependencies. 

    <code>dotnet restore</code>

6) Once the dependencies have installed, you can type the follow code to launch the program...

    <code>dotnet run</code>

    The program should launch in your console/terminal.

**Option 2** (via git console/terminal)
1) Open your Git enabled terminal/console and navigate to a directory that you wish to download this project to.
2) Type the following line of code into your terminal/console to automatically download the project to your current direcory and hit return/enter

    <code>git clone https://github.com/RMGit-it/Bakery.Solution</code><br>

3) Once the project has finished downloading, use the terminal/console to navigate to the "__bakery__" folder of the project.

4) Once there, type the following code and hit enter/return to install the necessary dependencies. 

    <code>dotnet restore</code>
    

5) Once the dependencies have installed, you can type the follow code to launch the program...

    <code>dotnet run</code>

    The program should launch in your console/terminal.
## **Usage / Examples**

Welcome to Pierre's Bakery!
Bread is $5 per loaf. (Buy on get one FREE!)
Pastry is $2 each, or 3 for $5.

To add some bread to your cart, please type 'bread'.
To add some pastry to your cart, please Type 'pastry'.
To puchase the items in your cart, please type 'purchase'.
To empty your cart, please type 'restart'.

Your shopping cart is empty.
bread

To add Rye bread, type 'rye'.
To add Wheat bread, type 'wheat'.
To add Gluten Free bread, type 'gf'.
To return to the previous menu, type 'back'. 
rye

How many loaves of this bread would you like in total?
There is a limit of 10 of each item per person, per order. Please input only whole numbers between 0 and 10
To return to the previous menu, type 'back'.
10
Your shopping cart has been updated.
     
To add some bread to your cart, please type 'bread'.
To add some pastry to your cart, please Type 'pastry'.
To puchase the items in your cart, please type 'purchase'.
To empty your cart, please type 'restart'.

Your shopping cart contains...
rye x 10, Your total comes to...
$35

## **Planned Features**
No new features are planned at this time.
## **Known Bugs**
There are no known bugs
## **Technology Used**
* C#
* .NET Core
## **Authors and Contributors**
Authored by: Randel Moore
## **Contact**
RMGit.it@gmail.com
## **License**

GPLv3

Copyright © 2020 Randel Moore