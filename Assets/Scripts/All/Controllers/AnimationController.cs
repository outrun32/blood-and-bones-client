using UnityEngine;

public class AnimationController
{
    private Animator _animator;

    public AnimationController(Animator animator)
    {
        _animator = animator;
    }
    public void Update(AnimationModel inputModel)
    {
        _animator.SetFloat("SpeedX", inputModel.SpeedX);
        _animator.SetFloat("SpeedY", inputModel.SpeedY);
        _animator.SetFloat("Speed", inputModel.Speed);
        //_animator.SetBool("Jump", inputModel.);
        _animator.SetBool("Attack", inputModel.IsAttack);
        _animator.SetBool("SuperAttack", inputModel.IsSupedAttack);
        _animator.SetInteger("AttakInd", inputModel.AttackInd);
        _animator.SetInteger("BlockInd", inputModel.BlockInd);
    }
}
