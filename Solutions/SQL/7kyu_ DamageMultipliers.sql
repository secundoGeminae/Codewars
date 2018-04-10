select pokemon_name,
       p.str*m.multiplier as modifiedstrength,
       m.element
from pokemon p
join multipliers m on p.element_id = m.id
where p.str*m.multiplier >=40 
order by  modifiedstrength desc
