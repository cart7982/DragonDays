EXTERNAL StartHostility(bool)
EXTERNAL StopHostility(bool)

-> OrangeTorchEnemy

=== OrangeTorchEnemy ===
VAR Name = "Orange Torch Enemy"


Will you collect 5 coins and bring them to my friend over there?
* [Yes]
    ~ StopHostility(true)
    Great
* [No]
    ~ StartHostility(true)
    Darn
- -> END