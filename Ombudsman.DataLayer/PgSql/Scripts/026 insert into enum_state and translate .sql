INSERT INTO enum_state (id, short_name, full_name)
VALUES (1, 'А', 'Актив');

INSERT INTO enum_state_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (1, 1, 'full_name', 'Фаол'),
  -- Uzbek Latin translations
  (1, 2, 'full_name', 'Faol'),
  -- Russian translations
  (1, 3, 'full_name', 'Актив');


INSERT INTO enum_state (id, short_name, full_name)
VALUES (2, 'П', 'Пассив');

INSERT INTO enum_state_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (2, 1, 'full_name', 'Нофаол'),
  -- Uzbek Latin translations
  (2, 2, 'full_name', 'Nofaol'),
  -- Russian translations
  (2, 3, 'full_name', 'Пассив');