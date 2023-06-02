Feature: Todoly Page Functionality of project

@Todoly @Login
Scenario: 01 Login
	Given I am on the Todoly login section
	When I enter my username "boris@gmail.com" and password "123456", both valid, and click login
	Then I should be logged in and see the Todoly logout button

@Todoly @CreateProject
Scenario: 02 Create project
	Given I am on the left section to click the add new project button
	When I enter the new project name "MojixProject" and click the add button
	Then The project name "MojixProject" should be displayed on the left site section

@Todoly @UpdateProject
Scenario: 03 Update project
	Given I am on the left section to click the project name "MojixProject"
	And I click on sub menu icon to click the edit button
	When I enter the updated project name "UpdatedProject" and click the save button
	Then The updated project name "UpdatedProject" should be displayed on the left site section

@Todoly @DeleteProject
Scenario: 04 Delete project
	Given I am on the left section to click the updated project name "UpdatedProject"
	And I click on sub menu icon to click the delete button
	When I accept the Alert message
	Then The project name "UpdatedProject" should no longer be displayed