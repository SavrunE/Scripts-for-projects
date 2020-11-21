    var hits = Physics.OverlapBox(transform.position, Vector3.forward * attackDistance);
            foreach (var hit in hits)
            {
                hit.GetComponent<Enemy>().Hit();
                OnHit?.Invoke();
            }
