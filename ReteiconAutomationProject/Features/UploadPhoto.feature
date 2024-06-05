Feature: UploadPhoto

As a user I want to upload a photo to create a profile

Background: 
    Given I navigate to the website "https://mentorskid.com"
    When I click login button
    Then  login welcome page displayed 
    When I enter the email address "nike@gmail.com"
    And I enter your Password "Mark123@"
    And I click submit button
    Then my profile page displayed

@tag1
Scenario: validation if a photo uploaded
    When I uploadPhoto "istockphoto-1476170969-170667a.webp"
	
    