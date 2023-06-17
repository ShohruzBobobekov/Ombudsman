
INSERT INTO public.enum_document_state
(id,order_number, short_name, full_name,state_id)
VALUES (1, '001', 'Лойиҳаланган', 'Лойиҳаланган',1);

INSERT INTO public.enum_document_state_tranlate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (1, 1, 'full_name', 'Лойиҳаланган'),
  -- Uzbek Latin translations
  (1, 2, 'full_name', 'Loyihalangan'),
  -- Russian translations
  (1, 3, 'full_name', 'Разработано');
  
  
INSERT INTO public.enum_document_state
(id,order_number, short_name, full_name,state_id)
VALUES (2, '002', 'Киритилган', 'Киритилган',1);

INSERT INTO public.enum_document_state_tranlate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (2, 1, 'full_name', 'Киритилган'),
  -- Uzbek Latin translations
  (2, 2, 'full_name', 'Kiritilgan'),
  -- Russian translations
  (2, 3, 'full_name', 'Вошел');

  
  
INSERT INTO public.enum_document_state
(id,order_number, short_name, full_name,state_id)
VALUES (3, '003', 'Рад етилган', 'Рад етилган',1);

INSERT INTO public.enum_document_state_tranlate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (3, 1, 'full_name', 'Рад етилган'),
  -- Uzbek Latin translations
  (3, 2, 'full_name', 'Rad yetilgan'),
  -- Russian translations
  (3, 3, 'full_name', 'Отклоненный');

  
INSERT INTO public.enum_document_state
(id,order_number, short_name, full_name,state_id)
VALUES (4, '004', 'Тасдиқланган', 'Тасдиқланган',1);

INSERT INTO public.enum_document_state_tranlate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (4, 1, 'full_name', 'Тасдиқланган'),
  -- Uzbek Latin translations
  (4, 2, 'full_name', 'Tasdiqlangan'),
  -- Russian translations
  (4, 3, 'full_name', 'Подтвержденный');

  
INSERT INTO public.enum_document_state
(id,order_number, short_name, full_name,state_id)
VALUES (5, '005', 'Кучга кирган', 'Кучга кирган',1);

INSERT INTO public.enum_document_state_tranlate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (5, 1, 'full_name', 'Кучга кирган'),
  -- Uzbek Latin translations
  (5, 2, 'full_name', 'Kuchga kirgan'),
  -- Russian translations
  (5, 3, 'full_name', 'Вступил в силу');