-- DROP TABLE IF EXISTS public.enum_state;

CREATE TABLE IF NOT EXISTS public.enum_state
(
    id integer primary key,
    short_name varchar(100),
    full_name varchar(100)
)