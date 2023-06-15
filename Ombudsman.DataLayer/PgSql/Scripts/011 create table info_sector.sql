-- Table: public.info_sector

-- DROP TABLE IF EXISTS public.info_sector;

CREATE TABLE IF NOT EXISTS public.info_sector
(
    id serial primary key,
    order_number text COLLATE pg_catalog."default" NOT NULL,
    sector_number text COLLATE pg_catalog."default" NOT NULL,
    state_id integer NOT NULL,
    full_name text COLLATE pg_catalog."default" NOT NULL,
    short_name text COLLATE pg_catalog."default" NOT NULL,
    created_date timestamp with time zone NOT NULL,
    created_user_id integer NOT NULL,
    updated_date timestamp with time zone NOT NULL,
    updated_user_id integer,
    CONSTRAINT fk_info_sector_enum_state_state_id FOREIGN KEY (state_id)
        REFERENCES public.enum_state (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)