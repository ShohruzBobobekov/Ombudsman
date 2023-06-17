-- DROP TABLE IF EXISTS public.info_sector;

CREATE TABLE IF NOT EXISTS public.info_sector
(
    id serial primary key,
    order_number varchar(100) NOT NULL,
    sector_number varchar(100) NOT NULL,
    state_id integer NOT NULL REFERENCES public.enum_state (id),
    full_name varchar(100) NOT NULL,
    short_name varchar(100) NOT NULL,
    created_date timestamp without time zone NOT NULL,
    created_user_id integer NOT NULL,
    updated_date timestamp without time zone,
    updated_user_id integer
)