select min(score),
percentile_cont (0.5) within group (order by score)::float as median,
max(score)
from result
