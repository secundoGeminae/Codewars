create function agecalculator(d date) returns integer as $$
begin
    return date_part('year', age(d));
end 
$$ language plpgsql;
