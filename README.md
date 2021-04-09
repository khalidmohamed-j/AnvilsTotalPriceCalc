# AnvilsTotalPriceCalc
AnvilsTotalPriceCalc

Builds test cases for Anvils, here are the criteria it uses. 

Calculates the volume discount for some quantity of anvils at some regular price
            
            Expected discount:
            1 - 9 anvils:      regular price.
            10 - 19 anvils:    10% discount.
            20 or more anvils: 20% discount.
            
            If either quantity or regPrice is 0, discount price should return 0

Return cost for requested shipping zone.
            
            Zones are 1 - 3:
            Zone 1: $10 per anvil.
            Zone 2: $20 per anvil.
            Zone 3: $30 per anvil.
            
            IndexOutOfRange exception if zone is not represented in array.
