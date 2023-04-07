Feature: StringsCounter

Count chars or words

Background:
    Given the phrase prefix is Phrase: .

@StringsCounter
Scenario: Get Word Count
    When the phrase is <phrase>
    Then the word count is <count>

    Examples:
    | phrase                         | count |
    | Behavior Driven Development    | 3     |
    | Here is four words             | 4     |
    | And here is five words         | 5     |

Scenario: Get Charachter Count
    When the phrase is <phrase>
    Then the char count is <count>
    
    Examples:
    | phrase                         | count |
    | Behavior Driven Development    | 32    |
    | Here is four words             | 22    |
    | And here is five words         | 25    |