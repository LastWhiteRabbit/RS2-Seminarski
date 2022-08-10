// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'exercise.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Exercise _$ExerciseFromJson(Map<String, dynamic> json) => Exercise()
  ..exerciseId = json['exerciseId'] as int?
  ..exerciseName = json['exerciseName'] as String?
  ..exerciseImage = json['exerciseImage'] as String?
  ..muscleNames = json['muscleNames'] as String?
  ..typeNames = json['typeNames'] as String?
  ..about = json['about'] as String?
  ..instruction = json['instruction'] as String?;

Map<String, dynamic> _$ExerciseToJson(Exercise instance) => <String, dynamic>{
      'exerciseId': instance.exerciseId,
      'exerciseName': instance.exerciseName,
      'exerciseImage': instance.exerciseImage,
      'muscleNames': instance.muscleNames,
      'typeNames': instance.typeNames,
      'about': instance.about,
      'instruction': instance.instruction,
    };
