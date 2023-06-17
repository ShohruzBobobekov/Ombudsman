-- Table: public.enum_user_role

-- DROP TABLE IF EXISTS public.enum_user_role;

CREATE TABLE IF NOT EXISTS public.enum_user_role
(
    id integer primary key,
    order_number varchar(100) NOT NULL,
    short_name varchar(100) NOT NULL,
    full_name varchar(100) NOT NULL,
    state_id integer NOT NULL REFERENCES public.enum_state (id)
)