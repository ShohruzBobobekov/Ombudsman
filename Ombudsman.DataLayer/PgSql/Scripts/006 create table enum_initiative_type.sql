-- Table: public.enum_initiative_type

-- DROP TABLE IF EXISTS public.enum_initiative_type;

CREATE TABLE IF NOT EXISTS public.enum_initiative_type
(
    id integer primary key,
    short_name varchar(100) NOT NULL,
    full_name varchar(100) NOT NULL
)