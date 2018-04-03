select t.id,t.heads, b.legs,t.arms,b.tails,
CASE WHEN b.legs<b.tails or t.heads>t.arms THEN 'BEAST'
    ELSE 'WEIRDO'
       END as SPECIES
    FROM top_half t
join bottom_half b on t.id = b.id ORDER BY SPECIES 
