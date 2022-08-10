import 'dart:convert';

import 'package:json_annotation/json_annotation.dart';

part 'exercise.g.dart';

@JsonSerializable()
class Exercise {
  int? exerciseId;
  String? exerciseName;
  String? exerciseImage;
  String? muscleNames;
  String? typeNames;
  String? about;
  String? instruction;

  Exercise() {}

  factory Exercise.fromJson(Map<String, dynamic> json) =>
      _$ExerciseFromJson(json);

  Map<String, dynamic> toJson() => _$ExerciseToJson(this);
}
