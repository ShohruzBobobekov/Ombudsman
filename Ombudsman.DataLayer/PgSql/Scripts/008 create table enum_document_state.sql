CREATE TABLE IF NOT EXISTS public.enum_document_state
(
    id integer primary key,
    order_number varchar(100) NOT NULL,
    short_name varchar(100) NOT NULL,
    full_name varchar(100) NOT NULL,
    state_id integer NOT NULL REFERENCES public.enum_state (id)
);