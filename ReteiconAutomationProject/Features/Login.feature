Feature: Login

A short summary of the feature

Background:
  Given I navigate to the website 
    When I click login button
    Then  login welcome page displayed

  @test
  Scenario: Valid Login
    When I enter the email address "nike@gmail.com"
    And I enter your Password "Mark123@"
    And I click submit button
    Then my profile page displayed


   
 