-- Table: public.hl_user

-- DROP TABLE IF EXISTS public.hl_user;

CREATE TABLE IF NOT EXISTS public.hl_user
(
    id serial primary key,
    first_name varchar(100) NOT NULL,
    last_name varchar(100) NOT NULL,
    username varchar(100) NOT NULL,
    role_id integer NOT NULL REFERENCES public.enum_user_role (id),
    email varchar(100) ,
    phone varchar(20) ,
    password_hash varchar(256),
    salt varchar(100),
    language_id integer NOT NULL,
    state_id integer NOT NULL REFERENCES public.enum_state (id),
    organization_id integer NOT NULL REFERENCES public.info_organization (id),
    refresh_token varchar(256),
    refresh_token_expire_date timestamp without time zone,
    created_at timestamp without time zone NOT NULL,
    created_user_id integer ,
    updated_at timestamp without time zone ,
    updated_user_id integer
);

