﻿Feature: MentorsRegistration
I want to register to become a mentor



  Background: 
    Given I navigate to the website 
    When I click join as a mentor
    Then welcome page displayed

  @test
  Scenario Outline: valid mentor registration
    When I enter first name "<firstName>"
    And I enter last name "<lastName>"
    And I enter the email "<emailAddress>"
    And I enter Password "<password>"
    And I click mentor checkbox
    And I click terms and condition
    #And I click join now
    #Then my profile page displayed

    Examples:
    | firstName | lastName | emailAddress   | password |
    | Louist    | Johnkh   | nike@gmail.com | Mark123@ |
    #|  Eusy       |   James     |    eusyhkoz@yahoo.com        |   Eusy123$    |

 @test
  Scenario Outline: invalid password mentor registration
    When I enter first name "<firstName>"
    And I enter last name "<lastName>"
    And I enter the email "<emailAddress>"
    And I enter Password "<password>"
    And I click mentor checkbox
    And I click terms and condition
    And I click join now
    #Then  the text "Password must be 8 characters"is displayed

    Examples:
      |firstName|lastName|emailAddress|password|
      |  Mark       |  John      |  amark@gmail.com    |    k123@   |
      #|  Eusy       |   James    |   eusy@yahoo.com   |   Eusy1    |

  @test
  Scenario Outline: Invalid  email address mentor registration
    When I enter first name "<firstName>"
    And I enter last name "<lastName>"
    And I enter the email "<emailAddress>"
    And I enter Password "<password>"
    And I click mentor checkbox
    And I click terms and condition
    And I click join now
   #Then the text "Please add a valid email address" is displayed

    Examples:
      |firstName|lastName|emailAddress|password|
      |  Mark       |  John      |  markgmail.com  |    Mark123@    |
      #|  Eusy       |   James    |    eusy@yahoo.  |   Eusy123$     |


 